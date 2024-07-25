import { Component, OnInit } from '@angular/core';
import { UserService } from '../../_services/user.service';
import { User } from '../../models/user';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {
  users: any[] = [];
  sortColumn: string = 'name';
  sortDirection: boolean = true;

  constructor(private userService: UserService) {}

  ngOnInit() {
    this.userService.getUsers().subscribe(data =>
       this.users = data
    );
  }

  sortBy(column: string): void {
    this.sortDirection = (this.sortColumn === column) ? !this.sortDirection : true;
    this.sortColumn = column;
    this.users = this.users.sort((a, b) => {
      if (a[column] > b[column]) return this.sortDirection ? 1 : -1;
      if (a[column] < b[column]) return this.sortDirection ? -1 : 1;
      return 0;
    });
  }
}
