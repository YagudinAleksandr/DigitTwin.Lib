# Скрипт для генерации C#-кода из всех .proto-файлов

$protoDir = "proto"
$outDir = "Generated/CSharp"

# Проверка наличия protoc
$protoc = "protoc"
if (-not (Get-Command $protoc -ErrorAction SilentlyContinue)) {
    Write-Error "protoc не найден. Установите Protocol Buffers Compiler и добавьте его в PATH."
    exit 1
}

# Создать папку вывода, если не существует
if (-not (Test-Path $outDir)) {
    New-Item -ItemType Directory -Path $outDir | Out-Null
}

# Генерация для всех .proto-файлов
Get-ChildItem -Path $protoDir -Filter *.proto | ForEach-Object {
    $protoFile = $_.FullName
    Write-Host "Генерация для $protoFile..."
    & $protoc --csharp_out=$outDir --proto_path=$protoDir $protoFile
}

Write-Host "Генерация завершена. Файлы в $outDir" 