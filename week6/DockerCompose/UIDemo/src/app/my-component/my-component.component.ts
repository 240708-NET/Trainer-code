import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { PostService } from '../Services/post.service';

@Component({
  selector: 'app-my-component',
  templateUrl: './my-component.component.html',
  styleUrls: ['./my-component.component.css']
})

export class MyComponentComponent implements OnInit {

  count: any;
  posts: any;
  result: any;

  constructor(private PS: PostService) { }

  ngOnInit(): void {
  }

  displayPosts()
  {
    this.PS.getPosts().subscribe((data) => {
      this.posts = data;
      this.result = null;
    });

    this.checkCount();
  }

  displayTime()
  {
    this.PS.getTime().subscribe((data) => {
      this.result = data;
      this.posts = null;
    });

    this.checkCount();
  }

  checkCount()
  {
    this.PS.getCount().subscribe((data) => {
      this.count = data;
    })
  }
}
