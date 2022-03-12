import { Component, OnInit } from '@angular/core';
import { IBook } from 'src/app/models/IBook';
import { BookService } from 'src/app/services/Book/book.service';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  booksList: IBook[] = [];
  constructor(private bookService:BookService) { }

  ngOnInit() {
    this.bookService.getAllBookks().subscribe({
      next:(books) =>
      {
        debugger
        console.log(books)
        this.booksList = books;
        console.log(this.booksList)
      }
    })
  }
}
