import type { EntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';

export interface KeywordDto extends EntityDto<number> {
  name: string;
  identityType: number;
}

export interface PagedCommonResultRequestDto extends PagedAndSortedResultRequestDto {
  keyword?: string;
  id: number;
  identityType: number;
}
