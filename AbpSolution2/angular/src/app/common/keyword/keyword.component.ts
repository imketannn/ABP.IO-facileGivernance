import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { KeywordService } from '@proxy/common';
import { KeywordDto } from '@proxy/common-module/common/dto';
// import { typeIdentityOptions } from '@proxy/common-module/common';

@Component({
  selector: 'app-keyword',
  templateUrl: './keyword.component.html',
  styleUrl: './keyword.component.scss',
  providers: [ListService, { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
})
export class KeywordComponent implements OnInit {
  keyword = { items: [], totalCount: 0 } as PagedResultDto<KeywordDto>;

  selectedKeyword = {} as KeywordDto; // declare selectedKeyword
  form: FormGroup;
  //  identityTypes = typeIdentityOptions;
   identityTypes = [
    { key: "Prospect", value: 1 },
    { key: "Content", value: 2 },
  ];

  isModalOpen = false;
  searchText: string = ''; // For search bar
  selectedIdentityType: number | null = 0; // For Identity Type dropdown

  constructor(
    public readonly list: ListService,
    private keywordService: KeywordService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService // inject the ConfirmationService
  ) {}

  ngOnInit() {
    debugger
    this.identityTypes;
    // this.moduleType;
    const keywordStreamCreator = query =>
      this.keywordService.getList({
        ...query,
        keyword: this.searchText,
        identityType: this.selectedIdentityType, // Pass selected Identity Type
      });

    this.list.hookToQuery(keywordStreamCreator).subscribe(response => {
      this.keyword = response;
    });
  }

  onSearch(): void {
    debugger
    // this.selectedIdentityType = Number.parseInt(this.selectedIdentityType.toString());
    this.list.get();
  }

  createKeyword() {
    this.selectedKeyword = {} as KeywordDto; // reset the selected keyword
    this.buildForm();
    this.isModalOpen = true;
  }

  editkeyword(id: number) {
    this.keywordService.get(id).subscribe(keyword => {
      this.selectedKeyword = keyword;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  delete(id: number) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe(status => {
      if (status === Confirmation.Status.confirm) {
        this.keywordService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  buildForm() {
    this.form = this.fb.group({
      name: [this.selectedKeyword.name || '', Validators.required],
      identityType: [this.selectedKeyword.identityType || null, Validators.required],
    });
  }

  // change the save method
  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedKeyword.id
      ? this.keywordService.update(this.selectedKeyword.id, this.form.value)
      : this.keywordService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}
