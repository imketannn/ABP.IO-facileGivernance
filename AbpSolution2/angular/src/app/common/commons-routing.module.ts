import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { authGuard, permissionGuard } from '@abp/ng.core';
import { KeywordComponent } from './keyword/keyword.component';
import { CommonmasterComponent } from './commonmaster/commonmaster.component';

const routes: Routes = [
  { path: '', component: CommonmasterComponent, canActivate: [authGuard, permissionGuard] },
  { path: 'keyword', component: KeywordComponent, canActivate: [authGuard, permissionGuard] },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CommonsRoutingModule {}
