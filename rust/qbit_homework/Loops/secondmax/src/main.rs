use std::io;
fn main() {
    println!("{}", solution());
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn solution() -> i16 {
    let mut max = i16::MIN;
    let mut second_max = max;
    loop {
        let num: i16 = input_line().trim().parse().unwrap();
        if num == 0 {break}
        if num > second_max { 
            if num > max { second_max = max; max = num; } 
            else { second_max = num; }
        }
    }
    second_max
}