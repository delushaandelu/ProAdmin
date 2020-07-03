import { Component, OnInit } from '@angular/core';
import { StudentDetailService } from './../../shared/student-detail.service';

@Component({
  selector: 'app-student-detail',
  templateUrl: './student-detail.component.html',
  styles: [
  ]
})
export class StudentDetailComponent implements OnInit {

  constructor(private service:StudentDetailService) { }

  ngOnInit(): void {
  }

}
