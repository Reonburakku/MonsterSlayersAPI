import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { RecoverComponent } from './auth/recover/recover.component';

const routes: Routes = [
  {
    path: '', component: LoginComponent
  },
  {
    path: 'login', component: LoginComponent
  },
  {
    path: 'register', component: RegisterComponent
  },
  {
    path: 'recover', component: RecoverComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
