import { Component, OnInit } from '@angular/core';
import { Book } from '../book';

@Component({
  selector: 'app-view-book',
  templateUrl: './view-book.component.html',
  styleUrls: ['./view-book.component.css']
})
export class ViewBookComponent  {
//initiate book object
book:Book;
  constructor() { 
    this.book=new Book(); //initiate book object
    this.book.bookId=342034;
    this.book.bookName="C#.Net 10.0";
    this.book.bookAuthor="Microsoft";
    this.book.bookLang="English";
    this.book.bookPrice=2300;
    this.book.bookReleaseDate=new Date(2022,1,5);
    this.book.isAvailable=true;
  }



}
