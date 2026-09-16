# Laravel Posts Project

A simple Laravel project implementing:

- Posts list page at `/posts`
- Post details page at `/posts/{id}`
- Hardcoded posts array (no database required)

## Run locally / in GitHub Codespaces

```bash
composer install
cp .env.example .env
php artisan key:generate
php artisan serve --host=0.0.0.0
```

Then open the forwarded port.

## Pages

- `/posts`
- `/posts/1`
- `/posts/2`
- `/posts/3`

Invalid IDs such as `/posts/99` return a 404 page.
