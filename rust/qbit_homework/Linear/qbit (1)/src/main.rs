use std::io;

fn main() {
    let (hr, mn) = solution(input_values());
    println!("{} {}", hr, mn);
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> f32 {
    input_line().trim().parse().unwrap()
}

fn solution(degree_total: f32) -> (u16,u16)  {
    ((degree_total/30.) as u16, (degree_total%30.*2.) as u16)
}