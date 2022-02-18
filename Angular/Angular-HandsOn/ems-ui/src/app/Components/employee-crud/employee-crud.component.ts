import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';
import { AdminService } from 'src/app/Services/admin.service';

@Component({
  selector: 'app-employee-crud',
  templateUrl: './employee-crud.component.html',
  styleUrls: ['./employee-crud.component.css']
})
export class EmployeeCrudComponent implements OnInit {
employees:Employee[];
employee:Employee;
projects=[
  {projectId:'P0001',projectName:'SMS'},
  {projectId:'P0002',projectName:'ECommerce'}
]
  constructor(private adminService:AdminService) { 
    this.employee=new Employee();
    this.GetEmployees();
  }

  ngOnInit(): void {
  }
  AddEmployee()
  {
    this.adminService.AddEmployee(this.employee).subscribe(response=>{
    this.employee=new Employee();
    this.GetEmployees();
    })
  }
  GetEmployee()
  {
    let eid=this.employee.employeeId;
    console.log(eid)
    this.adminService.GetEmployee(eid).subscribe(response=>{
      this.employee=response;
      console.log(this.employee);
    })
  }
  EditEmployee()
  {
    this.adminService.EditEmployee(this.employee).subscribe(response=>{
      this.GetEmployees();
  
    })
  }
  DeleteEmployee()
  {
    let eid=this.employee.employeeId;
    this.adminService.DeleteEmployee(eid).subscribe(response=>{
      this.GetEmployees();
     
    })
  }
  GetEmployees()
  {
    this.adminService.GetEmployees().subscribe(response=>{
      this.employees=response;
      console.log(this.employees)
    },(error)=>{
      console.log(error)
    })
  }


}
