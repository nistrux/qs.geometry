#!/bin/bash

set -e

echo "--- Building Podman image for tests ---"
podman build -f CoverageReport.Containerfile -t qs-geometry-tests .

echo "--- Launching container and generating report ---"
mkdir -p ./coverage-report
podman run --rm -v "$(pwd)/coverage-report:/app/CoverageReport:z" qs-geometry-tests

echo "--- Reports generated in ./coverage-report ---"
xdg-open ./coverage-report/index.html || echo "Open the HTML report manually: ./coverage-report/index.html"
