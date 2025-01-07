import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewKeywordComponent } from './view-keyword.component';

describe('ViewKeywordComponent', () => {
  let component: ViewKeywordComponent;
  let fixture: ComponentFixture<ViewKeywordComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ViewKeywordComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ViewKeywordComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
