import { Component } from '@angular/core';
import { MatFormField, MatInputModule } from '@angular/material/input';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { LoginService } from '../../services/login.service';
import { Router, RouterLink } from '@angular/router';
import { User, UserLogin } from '../../interfaces/user.interface';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [
    ReactiveFormsModule,
    MatInputModule,
    MatFormField,
    MatButtonModule,
    RouterLink,
  ],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {
  loginForm: FormGroup;
  constructor(
    private _loginService: LoginService,
    private _router: Router,
    private form: FormBuilder
  ) {
    this.loginForm = this.form.group({
      userName: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required),
    });
  }

  submit() {
    let user: UserLogin = {
      userName: this.loginForm.value.userName,
      password: this.loginForm.value.password,
    };
    this._loginService.login(user).subscribe({
      next: (res) => {
        console.log(res);
        this._router.navigate(['/dashboard']);
      },
      error: (err) => {
        console.log(err.error, err);
      },
    });
  }
}
