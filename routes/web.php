<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\PostController;

Route::get('/', function () {
    return redirect()->route('posts.index');
});

Route::get('/posts', [PostController::class, 'index'])->name('posts.index');

Route::get('/posts/{id}', [PostController::class, 'show'])
    ->whereNumber('id')
    ->name('posts.show');
