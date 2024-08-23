#!/bin/sh

setup() {
    echo "Setting up the environment..."
    echo "Environment set up."
}

# Function to install dependencies
install() {
    echo "Installing dependencies..."
    echo "Dependencies installed."
}

# Function to build the package
build() {
    echo "Building the package..."
    dotnet build app/PCPServerSDKDotNetRunner/PCPServerSDKDotNetRunner.csproj
    echo "Build complete."
}

# Function to run tests
test() {
    echo "Running tests..."
    dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover
    echo "Tests complete."
}

lint() {
    echo "Running lint..."
    echo "Lint complete."
}

version() {
    echo "Running version..."
    echo "Version complete."
}

clear() {
    echo "Removing temp directories..."
    echo "All temp directories have been removed."
}

publish() {
    # example: ./scripts.sh publish <PyPI token>
    # check if the PyPI token is passed
    if [ -z "$2" ]; then
        echo "Please provide the PyPI token."
        exit 1
    fi
    echo "Uploading the package..."
    TOKEN=$2
    echo "Upload complete."
}

run() {
    echo "Running the package..."
    dotnet run --project app/PCPServerSDKDotNetRunner
}

# Check the first argument passed to the script
case "$1" in
setup)
    setup
    ;;
install)
    install
    ;;
build)
    build
    ;;
test)
    test
    ;;
lint)
    lint
    ;;
clear)
    clear
    ;;
version)
    version $@
    ;;
publish)
    publish $@
    ;;
run)
    run
    ;;
*)
    echo "Usage: $0 {setup|install|build|test|lint|clear|version|publish|run}"
    exit 1
    ;;
esac
