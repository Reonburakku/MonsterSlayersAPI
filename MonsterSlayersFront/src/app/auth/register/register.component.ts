import { Component, OnInit, } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { ParamService } from '../../services/param.service';
import { Router } from '@angular/router';
import {
  FormControl,
  FormGroupDirective,
  NgForm,
  Validators,
  FormsModule,
  ReactiveFormsModule,
  AbstractControl,
} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  constructor(private router: Router, private authService: AuthService, private paramService: ParamService) { }

   validatePasswordMatch = (control: AbstractControl): {[key: string]: any} | null => {
    const password = this.passTxt as string;
    const passwordConfirm = control.value as string;
    if (password !== passwordConfirm) {
      return {passwordMatch: true};
    }
    return null;
  };

  validateEmailMatch = (control: AbstractControl): {[key: string]: any} | null => {
    const password = this.passTxt as string;
    const passwordConfirm = control.value as string;
    if (password !== passwordConfirm) {
      return {emailMatch: true};
    }
    return null;
  };

  bgImgURL: string = "https://monsterslayersrepo.s3.amazonaws.com/Zones/CityBackground.gif";
  usernameTxt: string = "";
  correoTxt: string = "";
  passTxt: string = "";
  confirmPassTxt: string = "";


  emailFormControl = new FormControl('', [Validators.required, Validators.email]);
  passFormControl = new FormControl('', [Validators.required, Validators.pattern('"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"')]);
  confirmPassFormControl = new FormControl('', [Validators.required, this.validatePasswordMatch]);
  confirmEmailFormControl = new FormControl('', [Validators.required, this.validateEmailMatch]);
  matcher = new MyErrorStateMatcher();

  ngOnInit(): void {
  }

  createBtn(){
    this.ExecuteRegister()
  }

  loginBtn(){
    this.router.navigate(['/login']);
  }

  getBackground() {
    this.paramService.GetAllZones().subscribe(data => {
      var response = JSON.parse(data);
      console.log(response);
    });
  }

  ExecuteRegister(){
    console.log(this.confirmPassFormControl);
    this.authService.Register(this.usernameTxt, this.correoTxt, this.passTxt).subscribe(data => {
      var response = JSON.parse(data);
      console.log(response);
    });
  }

}

export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
