use std::io;
fn main() {
    println!("{0:0.09}", solution());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution() -> f64 {
    let mut counter = 0;
    let mut sum = 0.;
    loop {
        let current_element: f64 = input_line().trim().parse().unwrap();
        if current_element == 0.0 {break}
        sum+=current_element;
        counter+=1;
    }
    sum/counter as f64
}