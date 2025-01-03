 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44368/',
  redirectUri: baseUrl,
  clientId: 'AbpSolution2_App',
  responseType: 'code',
  scope: 'offline_access AbpSolution2',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AbpSolution2',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44368',
      rootNamespace: 'AbpSolution2',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
