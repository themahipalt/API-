import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../Models/employee';
import { Project } from '../Models/project';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  api_path='http://localhost:23798/api/Admin/'
  constructor(private http:HttpClient) { }
  GetEmployees():Observable<Employee[]>
  {
    return this.http.get<Employee[]>(this.api_path+'GetEmployees');
  }
  GetEmployee(employeeId:number):Observable<Employee>
  {
    return this.http.get<Employee>(this.api_path+'GetEmployee/'+employeeId);
  }
  AddEmployee(employee:Employee):Observable<any>
  {
    return this.http.post(this.api_path+"AddEmployee",employee);
  }
  AddProject(project:Project):Observable<any>
  {
    return this.http.post(this.api_path+'AddProject',project);
  }
  EditEmployee(employee:Employee):Observable<any>
  {
    return this.http.put(this.api_path+"EditEmployee",employee);
  }
  DeleteEmployee(employeeId:number):Observable<any>
  {
    return this.http.delete(this.api_path+'DeleteEmployee/'+employeeId);
  }

}
