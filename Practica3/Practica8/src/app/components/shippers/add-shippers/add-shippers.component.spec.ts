import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddShippersComponent } from './add-shippers.component';

describe('AddShippersComponent', () => {
  let component: AddShippersComponent;
  let fixture: ComponentFixture<AddShippersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddShippersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddShippersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
