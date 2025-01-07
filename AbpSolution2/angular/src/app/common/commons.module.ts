import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { KeywordComponent } from './keyword/keyword.component';
import { CommonsRoutingModule } from './commons-routing.module';
import { ModalModule } from 'ngx-bootstrap/modal';
import { CommonModule } from '@angular/common';
import { NgxPaginationModule } from 'ngx-pagination';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
// import { HttpClientJsonpModule, HttpClientModule } from '@angular/common/http';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { CreateKeywordComponent } from './keyword/create-keyword/create-keyword.component';
import { EditKeywordComponent } from './keyword/edit-keyword/edit-keyword.component';
import { ViewKeywordComponent } from './keyword/view-keyword/view-keyword.component';
import { CommonmasterComponent } from './commonmaster/commonmaster.component';

@NgModule({
  declarations: [
    CommonmasterComponent,
    KeywordComponent,
    CreateKeywordComponent,
    EditKeywordComponent,
    ViewKeywordComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    // HttpClientModule,
    // HttpClientJsonpModule,
    ModalModule.forRoot(), // Add the type argument
    // BsDropdownModule,
    // BsDatepickerModule.forRoot(),
    CollapseModule,
    TabsModule,
    SharedModule,
    NgxPaginationModule,
    CommonsRoutingModule,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class CommonsModule {}
