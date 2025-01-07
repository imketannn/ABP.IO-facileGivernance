import { Component, OnInit } from '@angular/core';
import { KeywordDto } from '@proxy/common-module/common/dto';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { Keyword } from '../../Enum/keywordIdentity.model';

@Component({
  selector: 'app-view-keyword',
  templateUrl: './view-keyword.component.html',
  styleUrl: './view-keyword.component.scss',
})
export class ViewKeywordComponent implements OnInit  {
  keyword = {} as KeywordDto;
  Enum = Keyword;
  identityType: any;
  ModuleName = [
    { name: 'Prospect', value: 1 },
    { name: 'Content', value: 2 },
  ];
  constructor(public bsModalRef: BsModalRef) {}

  ngOnInit(): void {
    this.identityType = this.ModuleName.find(x => x.value == this.keyword.identityType).name;
  }
}
