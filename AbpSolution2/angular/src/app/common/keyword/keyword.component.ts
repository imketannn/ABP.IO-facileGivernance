import { Location } from '@angular/common';
import { Component, inject, OnInit } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { CreateKeywordComponent } from './create-keyword/create-keyword.component';
import { KeywordService } from '@proxy/common';
import { Confirmation, ConfirmationService } from '@abp/ng.theme.shared';
import { KeywordDto } from '@proxy/common-module/common/dto';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { ViewKeywordComponent } from './view-keyword/view-keyword.component';
import { EditKeywordComponent } from './edit-keyword/edit-keyword.component';

@Component({
  selector: 'app-keyword',
  templateUrl: './keyword.component.html',
  styleUrl: './keyword.component.scss',
  providers: [ListService],
})
export class KeywordComponent implements OnInit {
  modalService = inject(NgbModal);
  keyword = { items: [], totalCount: 0 } as PagedResultDto<KeywordDto>;

  selectedKeyword = {} as KeywordDto; // declare selectedKeyword
  identityTypes = [
    { key: 'Prospect', value: 1 },
    { key: 'Content', value: 2 },
  ];

  searchText: string = ''; // For search bar
  selectedIdentityType: number | null = 0; // For Identity Type dropdown
  identityType: number;

  constructor(
    public readonly list: ListService,
    private keywordService: KeywordService,
    private confirmation: ConfirmationService, // inject the ConfirmationService
    private _modalService: BsModalService,
    private location: Location
  ) {}

  ngOnInit() {
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
    this.list.get();
  }

  createKeyword() {
    this.selectedKeyword = {} as KeywordDto; // reset the selected keyword
    this.showCreateOrEditKeywordDialog(this.selectedKeyword);
  }

  editKeyword(keyword: KeywordDto): void {
    this.showCreateOrEditKeywordDialog(keyword);
  }
  back(): void {
    this.location.back();
  }
  viewKeyword(keyword: KeywordDto): void {
    let viewKeywordDialog: BsModalRef;
    viewKeywordDialog = this._modalService.show(ViewKeywordComponent, {
      class: 'modal-md',
      initialState: {
        keyword: keyword,
      },
    });
  }

  showCreateOrEditKeywordDialog(keyword: KeywordDto): void {
    let createOrEditKeywordDialog: BsModalRef;
    if (!keyword.id) {
      createOrEditKeywordDialog = this._modalService.show(CreateKeywordComponent, {
        class: 'modal-md',
        initialState: {
          identityType: this.identityType,
        },
      });
    } else {
      createOrEditKeywordDialog = this._modalService.show(EditKeywordComponent, {
        class: 'modal-md',
        initialState: {
          keyword: keyword,
          identityType: this.identityType,
        },
      });
    }
    createOrEditKeywordDialog.content.onSave.subscribe(() => {
      this.list.get();
    });
  }

  delete(id: number) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe(status => {
      if (status === Confirmation.Status.confirm) {
        this.keywordService.delete(id).subscribe(() => this.list.get());
      }
    });
  }
}
