import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { LeftBarComponent } from './left-bar/left-bar.component';
import { MainContentComponent } from './main-content/main-content.component';
import { RightBarComponent } from './right-bar/right-bar.component';
import { WrapperComponent } from './wrapper/wrapper.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { AuthService } from './services/auth.service';
import { UserService } from './services/user.service';
import { TopThemesComponent } from './top-themes/top-themes.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    LeftBarComponent,
    MainContentComponent,
    RightBarComponent,
    WrapperComponent,
    RegisterComponent,
    LoginComponent,
    TopThemesComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    AuthService,
    UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
