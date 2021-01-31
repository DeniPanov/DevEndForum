import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopThemesComponent } from './top-themes.component';

describe('TopThemesComponent', () => {
  let component: TopThemesComponent;
  let fixture: ComponentFixture<TopThemesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopThemesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TopThemesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
