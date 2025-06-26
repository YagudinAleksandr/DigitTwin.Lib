#!/bin/bash

PROTO_DIR="proto"
OUT_CS="Generated/CSharp"
OUT_JAVA="Generated/Java"
OUT_PY="Generated/Python"
OUT_GO="Generated/Go"

mkdir -p "$OUT_CS" "$OUT_JAVA" "$OUT_PY" "$OUT_GO"

for file in "$PROTO_DIR"/*.proto; do
  echo "Генерация для $file ..."
  protoc --csharp_out="$OUT_CS" --proto_path="$PROTO_DIR" "$file"
  protoc --java_out="$OUT_JAVA" --proto_path="$PROTO_DIR" "$file"
  protoc --python_out="$OUT_PY" --proto_path="$PROTO_DIR" "$file"
  protoc --go_out="$OUT_GO" --proto_path="$PROTO_DIR" "$file"
  echo "---"
done

echo "Генерация завершена." 