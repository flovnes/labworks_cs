use std::io;

fn main() {
    let (value, div) = input_values();

    println!("{}",solution(value, div));
}
fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (i64, i64) {
    let values: Vec<i64> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn solution(start_value: i64, div: i64) -> i64 { 
    if start_value + (div - start_value % div) == start_value + div || start_value == 0 {
        return start_value;
    }
    if start_value > 0 {
        start_value + (div - start_value % div)
    } else {
        start_value + (start_value % div).abs() 
    }
}`