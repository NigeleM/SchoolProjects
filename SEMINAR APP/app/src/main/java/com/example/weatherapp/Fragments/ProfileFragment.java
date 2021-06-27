package com.example.weatherapp.Fragments;

import android.util.Log;

import com.example.weatherapp.Post;
import com.parse.FindCallback;
import com.parse.ParseException;
import com.parse.ParseQuery;
import com.parse.ParseUser;

import java.util.List;

import static com.example.weatherapp.MainActivity.TAG;

public class ProfileFragment extends com.example.weatherapp.Fragments.PostsFragment {


    @Override
    protected void queryPosts() {
        super.queryPosts();
        ParseQuery<Post> query = ParseQuery.getQuery(Post.class);
        query.include(Post.KEY_USER);
        query.whereEqualTo(Post.KEY_USER, ParseUser.getCurrentUser());
        query.setLimit(20);
        query.addDescendingOrder(Post.KEY_CREATED_KEY);
        query.findInBackground(new FindCallback<Post>() {
            @Override
            public void done(List<Post> posts, ParseException e) {
                if(e != null){
                    Log.e(TAG,"Issue with retrieving post",e);
                    return;
                }
                for(Post post: posts)
                {
                    Log.i(TAG,"Post: "+ post.getDescription() + ", username: "+ post.getUser().getUsername());
                }
                allPosts.addAll(posts);
                adapter.notifyDataSetChanged();
            }
        });
    }
}
