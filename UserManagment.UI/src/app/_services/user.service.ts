import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map, Observable } from 'rxjs';
import { User } from '../models/user';
import { environment } from '../../environments/environment';
@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) {}

  getUsers(): Observable<User[]> {
    return this.http.get<{ result: any, value: User[] }>(environment.apiUrl + "users").pipe(
      map(response => response.value) 
    );  
  }

  addUser(user: User): Observable<any> {
    return this.http.post<any>(environment.apiUrl, user);
  }
}
