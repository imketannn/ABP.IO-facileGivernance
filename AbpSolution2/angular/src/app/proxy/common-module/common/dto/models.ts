import type { EntityDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';
import type { TypeIdentity } from '../type-identity.enum';

export interface KeywordDto extends EntityDto<number> {
  name: string;
  identyType: TypeIdentity;
}

export interface PagedCommonResultRequestDto extends PagedAndSortedResultRequestDto {
  keyword?: string;
  id: number;
  identyType: number;
}
