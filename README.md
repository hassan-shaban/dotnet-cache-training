# .NET Cache Training Project

A small .NET 8 console application for practicing GitHub Actions and NuGet caching.

## What this project demonstrates

- Restoring NuGet dependencies (`Newtonsoft.Json` is included so the NuGet cache has a package to store).
- Caching `~/.nuget/packages` with `actions/cache@v4`.
- Building with `dotnet build --no-restore` after the restore step.
- Using a cache key based on the `.csproj` file contents.
- Trying a fallback cache prefix with `restore-keys`.

## Upload to GitHub

1. Create a new empty repository on GitHub, for example `dotnet-cache-training`.
2. Extract this ZIP file.
3. Upload the contents of the `DotNetCacheTraining` folder to the repository root. Make sure `.github/workflows/dotnet-cache.yml` is included.
4. Commit the files to the `main` branch.
5. Open the repository's **Actions** tab and select **.NET Build with NuGet Cache**.
6. Click **Run workflow**.
7. Run it a second time and compare the **Cache NuGet packages** step. The first run will commonly miss and save a cache; a later run with the same key can hit it.

## Important note

The cache key hashes the `.csproj` file, so changing the package reference or its version changes the key. This is a simple training example; production workflows may use `packages.lock.json` with NuGet lock files for more precise dependency tracking.

Testing Pull Request Security Workflow
