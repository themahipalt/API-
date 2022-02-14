import { Component, OnInit } from '@angular/core';
import { Student } from '../student';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-student-crud',
  templateUrl: './student-crud.component.html',
  styleUrls: ['./student-crud.component.css']
})
export class StudentCrudComponent implements OnInit {
student:Student;
students:Student[];
stds:string[]=["I","II","III","IV"];
  constructor(private studentService:StudentService) { 
    this.student=new Student();
    this.students=this.studentService.GetAllStudents();
    console.log(this.stds)
  }

  ngOnInit(): void {
  }
  Save()
  {
    
    this.studentService.AddStudent(this.student);
    this.student=new Student();
  }
  Search()
  {
    let sid=this.student.studentId;
    this.student=this.studentService.GetStudent(sid);
  }

}
