import { Injectable } from '@angular/core';
import { Student } from './student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
students:Student[]=[]
  constructor() { }
  AddStudent(student:Student):void
  {
    this.students.push(student);
  }
  GetAllStudents():Student[]
  {
    return this.students;
  }
  GetStudent(studentId:number):Student
  {
    return this.students.find(s=>s.studentId==studentId);
  }
}
