import { mapEnumToOptions } from '@abp/ng.core';

export enum TypeIdentity {
  Asset = 1,
  Business = 2,
  CM = 3,
  Call = 4,
  Campaign = 5,
  EmailTemplate = 6,
  LeadAttachment = 7,
  LeadConversion = 8,
  Lead = 9,
  SalesTarget = 10,
  Employee = 11,
  Tracking = 12,
  EmailNotification = 13,
  TimesheetEmailNotification = 14,
}

export const typeIdentityOptions = mapEnumToOptions(TypeIdentity);
