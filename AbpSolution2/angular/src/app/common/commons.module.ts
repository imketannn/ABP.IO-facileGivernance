import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap'; // add this line
import { KeywordComponent } from './keyword/keyword.component';
import { CommonsRoutingModule } from './commons-routing.module';

@NgModule({
  declarations: [KeywordComponent],
  imports: [
    CommonsRoutingModule,
    SharedModule,
    NgbDatepickerModule, // add this line
  ]
})
export class CommonsModule { }
