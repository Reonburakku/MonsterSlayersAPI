import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { ParamService } from '../../services/param.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(private router: Router, private authService: AuthService, private paramService: ParamService) { }

  bgImgURL: string = "https://monsterslayersrepo.s3.amazonaws.com/Zones/CityBackground.gif";
  usernameTxt: string = "";
  passTxt: string = "";

  ngOnInit(): void {
  }

  loginBtn(){

  }

  registrarseBtn(){
    this.router.navigate(['/register']);
  }

  getBackground() {
    this.paramService.GetAllZones().subscribe(data => {
      var response = JSON.parse(data);
      console.log(response);
    })
  }

}
