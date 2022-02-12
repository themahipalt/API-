import { Component, OnInit } from '@angular/core';
import { Book } from '../book';
@Component({
  selector: 'app-view-books',
  templateUrl: './view-books.component.html',
  styleUrls: ['./view-books.component.css']
})
export class ViewBooksComponent implements OnInit {
books:Book[]
  constructor() { 
    this.books=[
      {bookId:33,bookName:'Angular',bookAuthor:'Aswini',bookPrice:350,bookLang:'English',bookReleaseDate:new Date(2022,1,4),isAvailable:true},
      {bookId:35,bookName:'React',bookAuthor:'Aswini',bookPrice:450,bookLang:'English',bookReleaseDate:new Date(2021,1,4),isAvailable:true},
      {bookId:37,bookName:'Vue',bookAuthor:'Mohith',bookPrice:550,bookLang:'English',bookReleaseDate:new Date(2020,1,4),isAvailable:true},
      {bookId:38,bookName:'Javascipt',bookAuthor:'Aswini',bookPrice:650,bookLang:'English',bookReleaseDate:new Date(2022,1,4),isAvailable:true},
      {bookId:31,bookName:'Bootstrap',bookAuthor:'Rishi',bookPrice:750,bookLang:'English',bookReleaseDate:new Date(2021,1,4),isAvailable:true},
    ]
  }

  ngOnInit(): void {
  }

}
