import {StudentDetail} from './student-detail.model';
import { Injectable } from '@angular/core';
import { from } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class StudentDetailService {
  formData:StudentDetail
  constructor() { }
}
