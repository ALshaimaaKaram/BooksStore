import { Component, OnInit } from '@angular/core';
import { BookService } from 'src/app/services/Book/book.service';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  booksList: any;
  constructor(private bookService:BookService) { }

  ngOnInit() {
    this.bookService.getAllBookks().subscribe({
      next:(books) =>
      {
        debugger
        console.log(books)
        this.booksList = books;
      }
    })
  }
}
