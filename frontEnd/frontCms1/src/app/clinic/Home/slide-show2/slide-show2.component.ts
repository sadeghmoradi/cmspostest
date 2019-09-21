import { Component, OnInit } from '@angular/core';
import {imgUrl} from 'src/app/clinic/modelclinic/imgUrl';


@Component({
  selector: 'app-slide-show2',
  templateUrl: './slide-show2.component.html',
  styleUrls: ['./slide-show2.component.scss']
})
export class SlideShow2Component implements OnInit {

  public imagesUrl2 :imgUrl[];
  constructor() { 
   
  }

  ngOnInit() {
    this.imagesUrl2 = [
      {txt : 'ss', url:'https://www.wcifly.com/images/medium/blog-pictures/oneweekinthailandfourkhaosoktrang8.jpg' }
      ,{txt:'ss',url:'../assets/A1.jpg'}
      ,{txt:'ss',url:'../assets/A2.jpg'}
      ,{txt:'ss',url:'../assets/A3.jpg'}
    ];
  }

}
