import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routes: RoutesService) {
  return () => {
    routes.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/books',
        name: '::Menu:Books',
        iconClass: 'fas fa-book',
        layout: eLayoutType.application,
        requiredPolicy: 'AbpSolution2.Books',
      },
      {
        path: '/common',
        name: '::Menu:Common',
        iconClass: 'fas fa-folder',
        layout: eLayoutType.application,
      },
      {
        path: '/common/keyword',
        parentName: '::Menu:Common', // Reference the parent menu by name
        name: '::Menu:Keywords',
        iconClass: 'fas fa-key',
        requiredPolicy: 'CommonModule.Keywords',
        layout: eLayoutType.application,
      },
    ]);
  };
}
