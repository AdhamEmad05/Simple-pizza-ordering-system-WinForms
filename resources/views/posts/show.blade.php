@extends('layouts.app')

@section('title', $post['title'])

@section('content')
    <h1>{{ $post['title'] }}</h1>

    <p>{{ $post['body'] }}</p>

    <a class="back" href="{{ route('posts.index') }}">← Back to Posts</a>
@endsection
