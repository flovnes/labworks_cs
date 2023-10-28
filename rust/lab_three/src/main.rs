use std::io;
fn main() {
    println!("Point A = (0;0)\nEnter point B:");
    let (a,b) = input_values();
    println!("Point B = ({};{})", a, b);
    let (area, point_c) = find_smallest_area((a,b));
    let (x,y) = point_c;
    println!("The smallest area for triangle ABC is {area:0.01} units squared with vertices A(0;0) B({a};{b}) C({x};{y})");
}

fn input_line() -> String {
    let mut input_line = String::new();
    let _ = io::stdin().read_line(&mut input_line);
    input_line
}

fn input_values() -> (i32,i32) {
    let values: Vec<i32> = input_line()
    .split_whitespace()
    .map(|q| q.parse().unwrap())
    .collect();
    (values[0], values[1])
}

fn triangle_area(point_b: (i32, i32), point_c: (i32, i32)) -> f32 {
    let (x_b,y_b) = point_b;
    let (x_c,y_c) = point_c;
    let area = ((x_b*y_c-x_c*y_b) as f32).abs()/2.0;
    println!("Area for C({};{}) = {}", x_c, y_c, area);
    area
}

fn find_smallest_area(point_b: (i32, i32)) -> (f32, (i32, i32)) {
    let (a,b) = point_b;
    let mut min_area = f32::MAX;
    let mut point_c: (i32, i32) = (0,0);
    let start = 0.min(a).min(b);
    let end = 0.max(a).max(b);
    for x in start..=end {
    for y in start..=end {
        if (x*b/a - y).abs() <= 2 {
            let cur_area = triangle_area((a,b), (x,y));
            if cur_area < min_area && cur_area > 0.0 { min_area = cur_area; point_c = (x,y) }
        }
    }
    }
    (min_area, point_c)
}