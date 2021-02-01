import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})

export class RegisterComponent implements OnInit {

  //registerForm: FormGroup;

  constructor(private router: Router) {
     //this.registerForm = this.fb.group({
     //  'fullname': ['', Validators.required],
     //  'username': ['', Validators.required],
     //  'email': ['', Validators.required],
     //  'password': ['', Validators.required]
     //})
   }

  ngOnInit(): void {
  }

  register(){
    //this.authService.register(this.registerForm.value).subscribe(data => {
    //  console.log(data);
    //})
  }
  
  //get fullname() {
  //  return this.registerForm.get('fullname')
  //}

  //get username() {
  //  return this.registerForm.get('username')
  // }

  //get email() {
  //  return this.registerForm.get('email')
  //}

  //get password() {
  //  return this.registerForm.get('password')
  //}
}
