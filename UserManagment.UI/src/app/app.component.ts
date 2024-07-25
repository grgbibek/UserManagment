import { Component, OnInit } from '@angular/core';
import { AuthService } from './_services/auth.service';
import { Token } from '@angular/compiler';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'User Management System';
  
  constructor(private authService: AuthService){
  }
  
  ngOnInit(): void {
    if(localStorage.getItem("token") == undefined || localStorage.getItem("token") !== null){
      this.authService.getToken().subscribe((res)=> {
        console.log(res);
        localStorage.setItem("token", res.token);
      })
    }
  }
}
