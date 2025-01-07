import { KeywordDto } from '@proxy/common-module/common/dto';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { KeywordService } from '@proxy/common';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Keyword } from '../../Enum/keywordIdentity.model';

@Component({
  selector: 'app-edit-keyword',
  templateUrl: './edit-keyword.component.html',
  styleUrl: './edit-keyword.component.scss',
})
export class EditKeywordComponent implements OnInit {
  keyword = {} as KeywordDto;
  identityType: number;
  form: FormGroup;
   Enum = Keyword;
   ModuleName = [
    { key: 'Prospect', value: 1 },
    { key: 'Content', value: 2 },
  ];
  // eslint-disable-next-line @angular-eslint/no-output-on-prefix
  @Output() onSave = new EventEmitter<any>();

  constructor(
    public bsModalRef: BsModalRef,
    private keywordService: KeywordService,
    private fb: FormBuilder
  ) {}

  ngOnInit(): void {
    this.buildForm();
  }

  buildForm() {
    this.form = this.fb.group({
      name: [this.keyword.name || '', Validators.required],
      identityType: [this.keyword.identityType || null, Validators.required],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    this.keywordService.update(this.keyword.id, this.form.value).subscribe(() => {
      this.form.reset();
      this.bsModalRef.hide();
      this.onSave.emit();
    });
  }
}
