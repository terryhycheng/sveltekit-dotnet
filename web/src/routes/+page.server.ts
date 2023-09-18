import type { PageServerLoad } from './$types';

type Todo = {
	id: number;
	task: string;
	isCompleted: boolean;
};

export const load: PageServerLoad = async () => {
	const response = await fetch('http://localhost:5255/api/todo');
	const data: Todo[] = await response.json();
	return {
		todos: data
	};
};
