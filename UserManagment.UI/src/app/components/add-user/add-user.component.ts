import { Component } from '@angular/core';
import { UserService } from '../../_services/user.service';
import { Router } from '@angular/router';
import { User } from '../../models/user';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent {
  user: User = {
    id:0,
    name: '',
    username:'',
    age: 0,
    phone: '',
    status: 0,
    designation: ''
  };

  constructor(private userService: UserService, private router: Router) {
  }

  addUser() {
    this.userService.addUser(this.user).subscribe(() => {
      this.router.navigate(['/users']);
    });
  }
}
