import { Byte } from '@angular/compiler/src/util';
import { Component, Input, OnInit } from '@angular/core';
import { IAuthor } from 'src/app/models/IAuthor';
import { IBook } from 'src/app/models/IBook';

@Component({
  selector: 'app-TableRow',
  templateUrl: './TableRow.component.html',
  styleUrls: ['./TableRow.component.css']
})
export class TableRowComponent implements OnInit {

  @Input() book:IBook = {} as IBook;
  constructor() {
    debugger
  }

  ngOnInit() {
  }

}
