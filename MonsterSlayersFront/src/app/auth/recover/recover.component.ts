import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { ParamService } from '../../services/param.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-recover',
  templateUrl: './recover.component.html',
  styleUrls: ['./recover.component.scss']
})
export class RecoverComponent {
  constructor(private router: Router, private authService: AuthService, private paramService: ParamService) { }

  bgImgURL: string = "https://monsterslayersrepo.s3.amazonaws.com/Zones/CityBackground.gif";
  correoTxt: string = "";
  passTxt: string = "";
  confirmPassTxt: string = "";

  ngOnInit(): void {
  }

  recoverBtn(){

  }

  loginBtn(){
    this.router.navigate(['/login']);
  }

  getBackground() {
    this.paramService.GetAllZones().subscribe(data => {
      var response = JSON.parse(data);
      console.log(response);
    })
  }
}
