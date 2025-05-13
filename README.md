# qs.geometry

A small .NET library to calculate areas of geometric shapes (circle, triangle) and detect whether a triangle is right-angled.

## ✅ Features

- [x] Compute area of a circle by radius
- [x] Compute area of a triangle by 3 sides
- [x] Detect if a triangle is right-angled
- [x] Easily extendable to other shapes
- [x] Supports polymorphic area calculation via interfaces

## 📦 Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Podman](https://podman.io/) (for local test coverage generation)

No external NuGet dependencies are required.

---

## 🧪 Local Code Coverage with Podman

To generate a local HTML test coverage report:

1. Make sure `CoverageReport.Containerfile` and `generate-coverage.sh` are in the project root.
2. Run the script:

   ```bash
   chmod +x generate-coverage.sh
   ./generate-coverage.sh
   ```
3. The report will be available in the `./coverage-report/index.html` file.
## 📥 Installation

This library is not published to NuGet. To use it locally:

1. Build the `.nupkg`:
   ```bash
   dotnet pack -c Release
   ```
2. Copy the `.nupkg` file to a local NuGet folder
3. Add the local source in your `NuGet.config`

## 💡 Example usage

```csharp
IShape shape1 = new Circle(5); //~78.53981
double area1 = shape1.GetArea();

ITriangle shape2 = new Triangle(3, 4, 5);
double area2 = shape2.GetArea(); //6
bool isRight = shape2.IsRightTriangle(); //True
```
