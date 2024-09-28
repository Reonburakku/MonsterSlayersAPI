import { booleanAttribute, Component, OnInit, } from '@angular/core';
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
  FormGroup,
} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import Swal from 'sweetalert2';

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
    const correo = this.correoTxt as string;
    const correoConfirm = control.value as string;
    if (correo !== correoConfirm) {
      return {emailMatch: true};
    }
    return null;
  };

  bgImgURL: string = "https://monsterslayersrepo.s3.amazonaws.com/Zones/CityBackground.gif";
  usernameTxt: string = "";
  correoTxt: string = "";
  confirmCorreoTxt: string = "";
  passTxt: string = "";
  confirmPassTxt: string = "";

  static regexStr ="(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])(?=.{8,})";

  userFormControl = new FormControl('', [Validators.required]);
  emailFormControl = new FormControl('', [Validators.required, Validators.email]);
  confirmEmailFormControl = new FormControl('', [Validators.required, this.validateEmailMatch]);
  passFormControl = new FormControl('', [Validators.required, Validators.pattern(new RegExp(RegisterComponent.regexStr))]);
  confirmPassFormControl = new FormControl('', [Validators.required, this.validatePasswordMatch]);
  matcher = new MyErrorStateMatcher();

  registerform = new FormGroup([
    this.userFormControl,
    this.emailFormControl,
    this.confirmEmailFormControl,
    this.passFormControl,
    this.confirmPassFormControl]);

  emailErrotTxt = "";
  emailErrotConfirmTxt = "";
  passwordErrorTxt = "";
  passwordErrorConfirmTxt = "";
  passwordTypeTxt = true;
  confirmPasswordTypeTxt = true;



  ngOnInit(): void {
  }

  createBtn(){
    if(this.registerform.valid){
      this.ExecuteRegister();
    }
  }

  loginBtn(){
    this.router.navigate(['/login']);
  }

  getBackground() {
    this.paramService.GetAllZones().subscribe(data => {
      var response = JSON.parse(data);
    });
  }

  ExecuteRegister(){
    this.authService.Register(this.usernameTxt, this.correoTxt, this.passTxt).subscribe(data => {
      console.log(data);
      Swal.fire({
        title: "Usuario creado",
        icon: "success",
        showCancelButton: false,
        confirmButtonColor: "#3f51b5",
        confirmButtonText: "Aceptar"
      }).then((result) => {
        if (result.isConfirmed) {
          this.router.navigate(['/login']);
        }
      });
    },
    error => {
      if(error.status == 500){
        Swal.fire({
          title: error.error.message,
          confirmButtonColor: "#3f51b5",
          icon: "warning"
        });
      }
    });
  }
}

export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
