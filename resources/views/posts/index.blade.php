@extends('layouts.app')

@section('title', 'Posts')

@section('content')
    <h1>Posts</h1>

    @foreach ($posts as $post)
        <div class="post">
            <h2>{{ $post['title'] }}</h2>
            <p>{{ $post['body'] }}</p>
            <a href="{{ route('posts.show', $post['id']) }}">View Post</a>
        </div>
    @endforeach
@endsection
