import { Component, OnInit } from '@angular/core';
import { Post } from '../post';
import { PostService } from '../post.service';

@Component({
  selector: 'app-view-posts',
  templateUrl: './view-posts.component.html',
  styleUrls: ['./view-posts.component.css']
})
export class ViewPostsComponent implements OnInit {
posts:Post[];
  constructor(private postService:PostService) {
    this.postService.GetPosts().subscribe(data=>{
      this.posts=data;
      console.log(this.posts);
    },err=>{
      console.log(err)
    })
   }

  ngOnInit(): void {
  }

}
