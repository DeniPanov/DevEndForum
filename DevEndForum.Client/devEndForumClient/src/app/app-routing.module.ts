import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { WrapperComponent } from './wrapper/wrapper.component';

const routes: Routes = [
  { path: '', redirectTo: '/home',pathMatch:"full"},
  { path: 'home', component: WrapperComponent},
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
