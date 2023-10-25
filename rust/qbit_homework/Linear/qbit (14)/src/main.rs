use std::io;

fn main() {
    let (value_1, value_2) = input_values();

    solution(value_1);
    solution(value_2);
    println!("----------");
    solution(value_1 + value_2);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (u64, u64) {
    let mut values: Vec<u64> = input_line()
            .split_whitespace()
            .map(|q| q.parse().unwrap())
            .collect();
        values.append(&mut input_line()
            .split_whitespace()
            .map(|q| q.parse().unwrap())
            .collect());

    (values[0], values[1])
}

fn solution(value: u64) {
    let mut spaces_needed: usize = 10 - value.to_string().len();
    let mut spaces_insert = String::new();

    while spaces_needed > 0 {
        spaces_insert = format!("{spaces_insert}{}", " ");
        spaces_needed -= 1;
    }

    println!("{}", format!("{}{}", spaces_insert, value));
}