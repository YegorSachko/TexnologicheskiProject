import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BotMenuComponent } from './bot-menu.component';

describe('BotMenuComponent', () => {
  let component: BotMenuComponent;
  let fixture: ComponentFixture<BotMenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BotMenuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BotMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
