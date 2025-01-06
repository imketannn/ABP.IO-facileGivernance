import { RestService, Rest } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { KeywordDto, PagedCommonResultRequestDto } from '../common-module/common/dto/models';

@Injectable({
  providedIn: 'root',
})
export class KeywordService {
  apiName = 'Default';
  

  create = (input: KeywordDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, KeywordDto>({
      method: 'POST',
      url: '/api/app/keyword',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: number, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/keyword/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: number, config?: Partial<Rest.Config>) =>
    this.restService.request<any, KeywordDto>({
      method: 'GET',
      url: `/api/app/keyword/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedCommonResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<KeywordDto>>({
      method: 'GET',
      url: '/api/app/keyword',
      params: { keyword: input.keyword, id: input.id, identityType: input.identityType, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: number, input: KeywordDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, KeywordDto>({
      method: 'PUT',
      url: `/api/app/keyword/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
