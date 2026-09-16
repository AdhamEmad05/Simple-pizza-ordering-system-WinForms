<?php

namespace App\Http\Controllers;

class PostController extends Controller
{
    private array $posts = [
        1 => [
            'id' => 1,
            'title' => 'My First Post',
            'body' => 'This is the content of my first post. Welcome to Laravel!',
        ],
        2 => [
            'id' => 2,
            'title' => 'Learning Laravel',
            'body' => 'Laravel makes it easy to build modern web applications with PHP.',
        ],
        3 => [
            'id' => 3,
            'title' => 'Working with Routes',
            'body' => 'Routes connect URLs to the code that handles each request.',
        ],
    ];

    public function index()
    {
        return view('posts.index', ['posts' => $this->posts]);
    }

    public function show(int $id)
    {
        if (!isset($this->posts[$id])) {
            abort(404);
        }

        return view('posts.show', ['post' => $this->posts[$id]]);
    }
}
